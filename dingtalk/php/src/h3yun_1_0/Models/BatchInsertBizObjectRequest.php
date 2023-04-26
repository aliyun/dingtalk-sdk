<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchInsertBizObjectRequest extends Model
{
    /**
     * @var string[]
     */
    public $bizObjectJsonArray;

    /**
     * @example true
     *
     * @var bool
     */
    public $isDraft;

    /**
     * @example 1eeb5ad3-b6da-4d4d-b6a5-8d342567d189
     *
     * @var string
     */
    public $opUserId;

    /**
     * @example D0001839bbbbe346bbf496498bb76c44c7eb972
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectJsonArray' => 'bizObjectJsonArray',
        'isDraft'            => 'isDraft',
        'opUserId'           => 'opUserId',
        'schemaCode'         => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectJsonArray) {
            $res['bizObjectJsonArray'] = $this->bizObjectJsonArray;
        }
        if (null !== $this->isDraft) {
            $res['isDraft'] = $this->isDraft;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchInsertBizObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectJsonArray'])) {
            if (!empty($map['bizObjectJsonArray'])) {
                $model->bizObjectJsonArray = $map['bizObjectJsonArray'];
            }
        }
        if (isset($map['isDraft'])) {
            $model->isDraft = $map['isDraft'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
