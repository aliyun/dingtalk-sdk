<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CustomizeContactCreateResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example alt:vndk1nd0
     *
     * @var string
     */
    public $code;

    /**
     * @example A项目通讯录
     *
     * @var string
     */
    public $name;

    /**
     * @example 1
     *
     * @var int
     */
    public $order;

    /**
     * @example 78933133
     *
     * @var int
     */
    public $rootDeptId;
    protected $_name = [
        'code'       => 'code',
        'name'       => 'name',
        'order'      => 'order',
        'rootDeptId' => 'rootDeptId',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->rootDeptId) {
            $res['rootDeptId'] = $this->rootDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['rootDeptId'])) {
            $model->rootDeptId = $map['rootDeptId'];
        }

        return $model;
    }
}
