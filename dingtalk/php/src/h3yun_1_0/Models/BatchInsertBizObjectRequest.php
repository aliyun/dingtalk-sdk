<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchInsertBizObjectRequest extends Model
{
    /**
     * @description 待新增的业对象json数组
     *
     * @var string[]
     */
    public $bizObjectJsonArray;

    /**
     * @description 是否是草稿数据。true=创建草稿数据，false=创建生效数据
     *
     * @var bool
     */
    public $isDraft;

    /**
     * @description 操作用户id
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 表单编码
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
