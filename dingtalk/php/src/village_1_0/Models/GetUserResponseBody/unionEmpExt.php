<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\unionEmpExt\unionEmpMapList;
use AlibabaCloud\Tea\Model;

class unionEmpExt extends Model
{
    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 关联映射关系
     *
     * @var unionEmpMapList[]
     */
    public $unionEmpMapList;
    protected $_name = [
        'corpId'          => 'corpId',
        'staffId'         => 'staffId',
        'unionEmpMapList' => 'unionEmpMapList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->unionEmpMapList) {
            $res['unionEmpMapList'] = [];
            if (null !== $this->unionEmpMapList && \is_array($this->unionEmpMapList)) {
                $n = 0;
                foreach ($this->unionEmpMapList as $item) {
                    $res['unionEmpMapList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return unionEmpExt
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['unionEmpMapList'])) {
            if (!empty($map['unionEmpMapList'])) {
                $model->unionEmpMapList = [];
                $n                      = 0;
                foreach ($map['unionEmpMapList'] as $item) {
                    $model->unionEmpMapList[$n++] = null !== $item ? unionEmpMapList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
