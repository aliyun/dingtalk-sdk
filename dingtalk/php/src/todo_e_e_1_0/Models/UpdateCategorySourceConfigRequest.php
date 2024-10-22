<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCategorySourceConfigRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1001
     *
     * @var string
     */
    public $bizCategoryId;

    /**
     * @description This parameter is required.
     *
     * @example 考勤_财务
     *
     * @var string
     */
    public $bizCategoryName;

    /**
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'bizCategoryId'   => 'bizCategoryId',
        'bizCategoryName' => 'bizCategoryName',
        'operatorId'      => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCategoryId) {
            $res['bizCategoryId'] = $this->bizCategoryId;
        }
        if (null !== $this->bizCategoryName) {
            $res['bizCategoryName'] = $this->bizCategoryName;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCategorySourceConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCategoryId'])) {
            $model->bizCategoryId = $map['bizCategoryId'];
        }
        if (isset($map['bizCategoryName'])) {
            $model->bizCategoryName = $map['bizCategoryName'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
