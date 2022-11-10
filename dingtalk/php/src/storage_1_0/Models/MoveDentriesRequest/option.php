<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\MoveDentriesRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 文件(夹)名称冲突策略
     * AUTO_RENAME
     * @var string
     */
    public $conflictStrategy;

    /**
     * @description 移动后，是否保留权限
     * false
     * @var bool
     */
    public $preservePermissions;
    protected $_name = [
        'conflictStrategy'    => 'conflictStrategy',
        'preservePermissions' => 'preservePermissions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conflictStrategy) {
            $res['conflictStrategy'] = $this->conflictStrategy;
        }
        if (null !== $this->preservePermissions) {
            $res['preservePermissions'] = $this->preservePermissions;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conflictStrategy'])) {
            $model->conflictStrategy = $map['conflictStrategy'];
        }
        if (isset($map['preservePermissions'])) {
            $model->preservePermissions = $map['preservePermissions'];
        }

        return $model;
    }
}
