<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteCategorySourceConfigRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1001
     *
     * @var string
     */
    public $bizCategoryId;
    protected $_name = [
        'bizCategoryId' => 'bizCategoryId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCategoryId) {
            $res['bizCategoryId'] = $this->bizCategoryId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteCategorySourceConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCategoryId'])) {
            $model->bizCategoryId = $map['bizCategoryId'];
        }

        return $model;
    }
}
