<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryChannelStaffInfoByMobileResponseBody\empInfo;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryChannelStaffInfoByMobileResponseBody\exclusiveAccountEmpInfoList;
use AlibabaCloud\Tea\Model;

class QueryChannelStaffInfoByMobileResponseBody extends Model
{
    /**
     * @var empInfo
     */
    public $empInfo;

    /**
     * @var exclusiveAccountEmpInfoList[]
     */
    public $exclusiveAccountEmpInfoList;
    protected $_name = [
        'empInfo' => 'empInfo',
        'exclusiveAccountEmpInfoList' => 'exclusiveAccountEmpInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->empInfo) {
            $res['empInfo'] = null !== $this->empInfo ? $this->empInfo->toMap() : null;
        }
        if (null !== $this->exclusiveAccountEmpInfoList) {
            $res['exclusiveAccountEmpInfoList'] = [];
            if (null !== $this->exclusiveAccountEmpInfoList && \is_array($this->exclusiveAccountEmpInfoList)) {
                $n = 0;
                foreach ($this->exclusiveAccountEmpInfoList as $item) {
                    $res['exclusiveAccountEmpInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryChannelStaffInfoByMobileResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['empInfo'])) {
            $model->empInfo = empInfo::fromMap($map['empInfo']);
        }
        if (isset($map['exclusiveAccountEmpInfoList'])) {
            if (!empty($map['exclusiveAccountEmpInfoList'])) {
                $model->exclusiveAccountEmpInfoList = [];
                $n = 0;
                foreach ($map['exclusiveAccountEmpInfoList'] as $item) {
                    $model->exclusiveAccountEmpInfoList[$n++] = null !== $item ? exclusiveAccountEmpInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
