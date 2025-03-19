<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest\relationList;
use AlibabaCloud\Tea\Model;

class BatchAddRelationDatasRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example manager021a
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description This parameter is required.
     *
     * @var relationList[]
     */
    public $relationList;

    /**
     * @description This parameter is required.
     *
     * @example crm_customer
     *
     * @var string
     */
    public $relationType;

    /**
     * @example false
     *
     * @var bool
     */
    public $skipDuplicateCheck;
    protected $_name = [
        'operatorUserId' => 'operatorUserId',
        'relationList' => 'relationList',
        'relationType' => 'relationType',
        'skipDuplicateCheck' => 'skipDuplicateCheck',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->relationList) {
            $res['relationList'] = [];
            if (null !== $this->relationList && \is_array($this->relationList)) {
                $n = 0;
                foreach ($this->relationList as $item) {
                    $res['relationList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->skipDuplicateCheck) {
            $res['skipDuplicateCheck'] = $this->skipDuplicateCheck;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchAddRelationDatasRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['relationList'])) {
            if (!empty($map['relationList'])) {
                $model->relationList = [];
                $n = 0;
                foreach ($map['relationList'] as $item) {
                    $model->relationList[$n++] = null !== $item ? relationList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['skipDuplicateCheck'])) {
            $model->skipDuplicateCheck = $map['skipDuplicateCheck'];
        }

        return $model;
    }
}
