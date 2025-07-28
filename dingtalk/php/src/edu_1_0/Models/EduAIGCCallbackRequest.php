<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class EduAIGCCallbackRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example test
     *
     * @var string
     */
    public $channelCode;

    /**
     * @var int
     */
    public $commitTime;

    /**
     * @var int
     */
    public $completeTime;

    /**
     * @description This parameter is required.
     *
     * @example http://xxxxx.doc
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example 1500
     *
     * @var int
     */
    public $contentSize;

    /**
     * @description This parameter is required.
     *
     * @example url
     *
     * @var string
     */
    public $contentType;

    /**
     * @var string
     */
    public $ext;

    /**
     * @description This parameter is required.
     *
     * @example 请帮我写一篇读后感
     *
     * @var string
     */
    public $prompt;

    /**
     * @var string
     */
    public $remark;
    protected $_name = [
        'channelCode' => 'channelCode',
        'commitTime' => 'commitTime',
        'completeTime' => 'completeTime',
        'content' => 'content',
        'contentSize' => 'contentSize',
        'contentType' => 'contentType',
        'ext' => 'ext',
        'prompt' => 'prompt',
        'remark' => 'remark',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }
        if (null !== $this->commitTime) {
            $res['commitTime'] = $this->commitTime;
        }
        if (null !== $this->completeTime) {
            $res['completeTime'] = $this->completeTime;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->contentSize) {
            $res['contentSize'] = $this->contentSize;
        }
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->prompt) {
            $res['prompt'] = $this->prompt;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EduAIGCCallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }
        if (isset($map['commitTime'])) {
            $model->commitTime = $map['commitTime'];
        }
        if (isset($map['completeTime'])) {
            $model->completeTime = $map['completeTime'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['contentSize'])) {
            $model->contentSize = $map['contentSize'];
        }
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['prompt'])) {
            $model->prompt = $map['prompt'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }

        return $model;
    }
}
