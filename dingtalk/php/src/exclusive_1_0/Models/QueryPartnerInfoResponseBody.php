<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoResponseBody\partnerDeptList;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoResponseBody\partnerLabelList;
use AlibabaCloud\Tea\Model;

class QueryPartnerInfoResponseBody extends Model
{
    /**
     * @description 部门列表
     *
     * @var partnerDeptList[]
     */
    public $partnerDeptList;

    /**
     * @description 伙伴标签
     *
     * @var partnerLabelList[]
     */
    public $partnerLabelList;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'partnerDeptList'  => 'partnerDeptList',
        'partnerLabelList' => 'partnerLabelList',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->partnerDeptList) {
            $res['partnerDeptList'] = [];
            if (null !== $this->partnerDeptList && \is_array($this->partnerDeptList)) {
                $n = 0;
                foreach ($this->partnerDeptList as $item) {
                    $res['partnerDeptList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->partnerLabelList) {
            $res['partnerLabelList'] = [];
            if (null !== $this->partnerLabelList && \is_array($this->partnerLabelList)) {
                $n = 0;
                foreach ($this->partnerLabelList as $item) {
                    $res['partnerLabelList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPartnerInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['partnerDeptList'])) {
            if (!empty($map['partnerDeptList'])) {
                $model->partnerDeptList = [];
                $n                      = 0;
                foreach ($map['partnerDeptList'] as $item) {
                    $model->partnerDeptList[$n++] = null !== $item ? partnerDeptList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['partnerLabelList'])) {
            if (!empty($map['partnerLabelList'])) {
                $model->partnerLabelList = [];
                $n                       = 0;
                foreach ($map['partnerLabelList'] as $item) {
                    $model->partnerLabelList[$n++] = null !== $item ? partnerLabelList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
