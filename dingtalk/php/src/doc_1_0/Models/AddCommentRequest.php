<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddCommentRequest\option;
use AlibabaCloud\Tea\Model;

class AddCommentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $commentContent;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $commentType;

    /**
     * @var option
     */
    public $option;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'commentContent' => 'commentContent',
        'commentType'    => 'commentType',
        'option'         => 'option',
        'operatorId'     => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->commentContent) {
            $res['commentContent'] = $this->commentContent;
        }
        if (null !== $this->commentType) {
            $res['commentType'] = $this->commentType;
        }
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCommentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commentContent'])) {
            $model->commentContent = $map['commentContent'];
        }
        if (isset($map['commentType'])) {
            $model->commentType = $map['commentType'];
        }
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
