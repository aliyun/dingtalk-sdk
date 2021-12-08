<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryRequest;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryRequest\queryParams\conditionList;
use AlibabaCloud\Tea\Model;

class queryParams extends Model
{
    /**
     * @description 需要筛选的字段
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @description 筛选条件连接类型
     *
     * @var string
     */
    public $joinType;

    /**
     * @description 筛选条件
     *
     * @var conditionList[]
     */
    public $conditionList;
    protected $_name = [
        'fieldCode'     => 'fieldCode',
        'joinType'      => 'joinType',
        'conditionList' => 'conditionList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->joinType) {
            $res['joinType'] = $this->joinType;
        }
        if (null !== $this->conditionList) {
            $res['conditionList'] = [];
            if (null !== $this->conditionList && \is_array($this->conditionList)) {
                $n = 0;
                foreach ($this->conditionList as $item) {
                    $res['conditionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return queryParams
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['joinType'])) {
            $model->joinType = $map['joinType'];
        }
        if (isset($map['conditionList'])) {
            if (!empty($map['conditionList'])) {
                $model->conditionList = [];
                $n                    = 0;
                foreach ($map['conditionList'] as $item) {
                    $model->conditionList[$n++] = null !== $item ? conditionList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
