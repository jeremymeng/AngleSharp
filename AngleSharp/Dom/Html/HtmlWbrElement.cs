﻿namespace AngleSharp.Dom.Html
{
    using AngleSharp.Html;
    using System;

    /// <summary>
    /// Represents the HTML wbr (word-break-opportunity) element.
    /// This element is used to indicate that the position is a good
    /// point for inserting a possible line-break.
    /// </summary>
    sealed class HtmlWbrElement : HtmlElement
    {
        /// <summary>
        /// Creates a new HTML wbr element.
        /// </summary>
        public HtmlWbrElement(Document owner, String prefix = null)
            : base(owner, TagNames.Wbr, prefix, NodeFlags.Special | NodeFlags.SelfClosing)
        {
        }
    }
}
