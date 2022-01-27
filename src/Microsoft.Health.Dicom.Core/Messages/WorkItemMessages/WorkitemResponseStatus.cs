﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Dicom.Core.Messages.WorkitemMessages
{
    /// <summary>
    /// Represents the add work-item response status.
    /// </summary>
    public enum WorkitemResponseStatus
    {
        /// <summary>
        /// There is no DICOM instance to store.
        /// </summary>
        None,

        /// <summary>
        /// All DICOM work-item instance(s) have been stored successfully.
        /// </summary>
        Success,

        /// <summary>
        /// All DICOM work-item instance(s) have failed to be stored.
        /// </summary>
        Failure,
    }
}