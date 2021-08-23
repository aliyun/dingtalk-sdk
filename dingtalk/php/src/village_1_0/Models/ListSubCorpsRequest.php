<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSubCorpsRequest extends Model
{
    /**
     * @description 下级指定组织层级列表，组织层级为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区，如果查多个用 '|' 分隔
     *
     * @var string
     */
    public $types;

    /**
     * @description 真正查询的组织corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 是否查询直接下级
     *
     * @var bool
     */
    public $isOnlyDirect;
    protected $_name = [
        'types'        => 'types',
        'subCorpId'    => 'subCorpId',
        'isOnlyDirect' => 'isOnlyDirect',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->types) {
            $res['types'] = $this->types;
        }
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->isOnlyDirect) {
            $res['isOnlyDirect'] = $this->isOnlyDirect;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSubCorpsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['types'])) {
            $model->types = $map['types'];
        }
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['isOnlyDirect'])) {
            $model->isOnlyDirect = $map['isOnlyDirect'];
        }

        return $model;
    }
}
