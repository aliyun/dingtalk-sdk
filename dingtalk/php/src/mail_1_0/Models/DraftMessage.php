<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\DraftMessage\body;
use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class DraftMessage extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var Recipient[]
     */
    public $bccRecipients;

    /**
     * @description This parameter is required.
     *
     * @var body
     */
    public $body;

    /**
     * @description This parameter is required.
     *
     * @var Recipient[]
     */
    public $ccRecipients;

    /**
     * @description This parameter is required.
     *
     * @var Recipient
     */
    public $from;

    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $internetMessageHeaders;

    /**
     * @description This parameter is required.
     *
     * @example uniqid@dingtalk.com
     *
     * @var Stream
     */
    public $internetMessageId;

    /**
     * @description This parameter is required.
     *
     * @example false
     *
     * @var bool
     */
    public $isReadReceiptRequested;

    /**
     * @description This parameter is required.
     *
     * @example PRY_NORMAL
     *
     * @var Stream
     */
    public $priority;

    /**
     * @description This parameter is required.
     *
     * @var Recipient
     */
    public $replyTo;

    /**
     * @description This parameter is required.
     *
     * @example 主题
     *
     * @var Stream
     */
    public $subject;

    /**
     * @description This parameter is required.
     *
     * @var Stream
     */
    public $summary;

    /**
     * @description This parameter is required.
     *
     * @var Stream[]
     */
    public $tags;

    /**
     * @description This parameter is required.
     *
     * @var Recipient[]
     */
    public $toRecipients;
    protected $_name = [
        'bccRecipients' => 'bccRecipients',
        'body' => 'body',
        'ccRecipients' => 'ccRecipients',
        'from' => 'from',
        'internetMessageHeaders' => 'internetMessageHeaders',
        'internetMessageId' => 'internetMessageId',
        'isReadReceiptRequested' => 'isReadReceiptRequested',
        'priority' => 'priority',
        'replyTo' => 'replyTo',
        'subject' => 'subject',
        'summary' => 'summary',
        'tags' => 'tags',
        'toRecipients' => 'toRecipients',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bccRecipients) {
            $res['bccRecipients'] = [];
            if (null !== $this->bccRecipients && \is_array($this->bccRecipients)) {
                $n = 0;
                foreach ($this->bccRecipients as $item) {
                    $res['bccRecipients'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->body) {
            $res['body'] = null !== $this->body ? $this->body->toMap() : null;
        }
        if (null !== $this->ccRecipients) {
            $res['ccRecipients'] = [];
            if (null !== $this->ccRecipients && \is_array($this->ccRecipients)) {
                $n = 0;
                foreach ($this->ccRecipients as $item) {
                    $res['ccRecipients'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->from) {
            $res['from'] = null !== $this->from ? $this->from->toMap() : null;
        }
        if (null !== $this->internetMessageHeaders) {
            $res['internetMessageHeaders'] = $this->internetMessageHeaders;
        }
        if (null !== $this->internetMessageId) {
            $res['internetMessageId'] = $this->internetMessageId;
        }
        if (null !== $this->isReadReceiptRequested) {
            $res['isReadReceiptRequested'] = $this->isReadReceiptRequested;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->replyTo) {
            $res['replyTo'] = null !== $this->replyTo ? $this->replyTo->toMap() : null;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->tags) {
            $res['tags'] = $this->tags;
        }
        if (null !== $this->toRecipients) {
            $res['toRecipients'] = [];
            if (null !== $this->toRecipients && \is_array($this->toRecipients)) {
                $n = 0;
                foreach ($this->toRecipients as $item) {
                    $res['toRecipients'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DraftMessage
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bccRecipients'])) {
            if (!empty($map['bccRecipients'])) {
                $model->bccRecipients = [];
                $n = 0;
                foreach ($map['bccRecipients'] as $item) {
                    $model->bccRecipients[$n++] = null !== $item ? Recipient::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['body'])) {
            $model->body = body::fromMap($map['body']);
        }
        if (isset($map['ccRecipients'])) {
            if (!empty($map['ccRecipients'])) {
                $model->ccRecipients = [];
                $n = 0;
                foreach ($map['ccRecipients'] as $item) {
                    $model->ccRecipients[$n++] = null !== $item ? Recipient::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['from'])) {
            $model->from = Recipient::fromMap($map['from']);
        }
        if (isset($map['internetMessageHeaders'])) {
            $model->internetMessageHeaders = $map['internetMessageHeaders'];
        }
        if (isset($map['internetMessageId'])) {
            $model->internetMessageId = $map['internetMessageId'];
        }
        if (isset($map['isReadReceiptRequested'])) {
            $model->isReadReceiptRequested = $map['isReadReceiptRequested'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['replyTo'])) {
            $model->replyTo = Recipient::fromMap($map['replyTo']);
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['tags'])) {
            if (!empty($map['tags'])) {
                $model->tags = $map['tags'];
            }
        }
        if (isset($map['toRecipients'])) {
            if (!empty($map['toRecipients'])) {
                $model->toRecipients = [];
                $n = 0;
                foreach ($map['toRecipients'] as $item) {
                    $model->toRecipients[$n++] = null !== $item ? Recipient::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
