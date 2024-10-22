<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\GetCategorySourceConfigListResponseBody;

use AlibabaCloud\Tea\Model;

class configs extends Model
{
    /**
     * @var string
     */
    public $bizCategoryId;

    /**
     * @var string
     */
    public $bizCategoryName;

    /**
     * @var string
     */
    public $configId;
    protected $_name = [
        'bizCategoryId'   => 'bizCategoryId',
        'bizCategoryName' => 'bizCategoryName',
        'configId'        => 'configId',
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
        if (null !== $this->configId) {
            $res['configId'] = $this->configId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return configs
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
        if (isset($map['configId'])) {
            $model->configId = $map['configId'];
        }

        return $model;
    }
}
