<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CustomizeContactUpdateRequest extends Model
{
    /**
     * @description 自定义通讯录Code
     *
     * @var string
     */
    public $code;

    /**
     * @description 通讯录管理员UserId
     *
     * @var string[]
     */
    public $managerIdList;

    /**
     * @description 自定义通讯录名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 在自定义通讯录列表中的排序
     *
     * @var int
     */
    public $order;
    protected $_name = [
        'code'          => 'code',
        'managerIdList' => 'managerIdList',
        'name'          => 'name',
        'order'         => 'order',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->managerIdList) {
            $res['managerIdList'] = $this->managerIdList;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CustomizeContactUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['managerIdList'])) {
            if (!empty($map['managerIdList'])) {
                $model->managerIdList = $map['managerIdList'];
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }

        return $model;
    }
}
