<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateSpaceRequest;

use AlibabaCloud\Tea\Model;

class shareScope extends Model
{
    /**
     * @description 公开范围。
     * 1-当前组织所有人可见。
     * @var int
     */
    public $scope;
    protected $_name = [
        'scope' => 'scope',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return shareScope
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }

        return $model;
    }
}
