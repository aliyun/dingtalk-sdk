<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReplyRequest extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contentType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $conversationToken;
    protected $_name = [
        'content'           => 'content',
        'contentType'       => 'contentType',
        'conversationToken' => 'conversationToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->conversationToken) {
            $res['conversationToken'] = $this->conversationToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReplyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['conversationToken'])) {
            $model->conversationToken = $map['conversationToken'];
        }

        return $model;
    }
}
