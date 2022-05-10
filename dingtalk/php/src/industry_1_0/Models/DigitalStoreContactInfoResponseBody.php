<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreContactInfoResponseBody extends Model
{
    /**
     * @description 门店通通讯录Code
     *
     * @var string
     */
    public $code;

    /**
     * @description 门店通通讯录名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 门店通通讯录根节点Id
     *
     * @var int
     */
    public $rootDeptId;
    protected $_name = [
        'code'       => 'code',
        'name'       => 'name',
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
        if (null !== $this->rootDeptId) {
            $res['rootDeptId'] = $this->rootDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreContactInfoResponseBody
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
        if (isset($map['rootDeptId'])) {
            $model->rootDeptId = $map['rootDeptId'];
        }

        return $model;
    }
}
