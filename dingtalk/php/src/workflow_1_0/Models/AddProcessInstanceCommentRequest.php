<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddProcessInstanceCommentRequest\file;
use AlibabaCloud\Tea\Model;

class AddProcessInstanceCommentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example user123
     *
     * @var string
     */
    public $commentUserId;

    /**
     * @var file
     */
    public $file;

    /**
     * @description This parameter is required.
     *
     * @example a171de6c-8bxxxx
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description This parameter is required.
     *
     * @example 同意。
     *
     * @var string
     */
    public $text;
    protected $_name = [
        'commentUserId'     => 'commentUserId',
        'file'              => 'file',
        'processInstanceId' => 'processInstanceId',
        'text'              => 'text',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->commentUserId) {
            $res['commentUserId'] = $this->commentUserId;
        }
        if (null !== $this->file) {
            $res['file'] = null !== $this->file ? $this->file->toMap() : null;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddProcessInstanceCommentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commentUserId'])) {
            $model->commentUserId = $map['commentUserId'];
        }
        if (isset($map['file'])) {
            $model->file = file::fromMap($map['file']);
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }

        return $model;
    }
}
