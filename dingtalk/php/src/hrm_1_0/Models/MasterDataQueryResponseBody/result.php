<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result\viewEntityFieldVOList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example uk123123
     *
     * @var string
     */
    public $outerId;

    /**
     * @description This parameter is required.
     *
     * @example admind123
     *
     * @var string
     */
    public $relationId;

    /**
     * @description This parameter is required.
     *
     * @example PERFORMANCE
     *
     * @var string
     */
    public $scopeCode;

    /**
     * @description This parameter is required.
     *
     * @example base
     *
     * @var string
     */
    public $viewEntityCode;

    /**
     * @var viewEntityFieldVOList[]
     */
    public $viewEntityFieldVOList;
    protected $_name = [
        'outerId' => 'outerId',
        'relationId' => 'relationId',
        'scopeCode' => 'scopeCode',
        'viewEntityCode' => 'viewEntityCode',
        'viewEntityFieldVOList' => 'viewEntityFieldVOList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->outerId) {
            $res['outerId'] = $this->outerId;
        }
        if (null !== $this->relationId) {
            $res['relationId'] = $this->relationId;
        }
        if (null !== $this->scopeCode) {
            $res['scopeCode'] = $this->scopeCode;
        }
        if (null !== $this->viewEntityCode) {
            $res['viewEntityCode'] = $this->viewEntityCode;
        }
        if (null !== $this->viewEntityFieldVOList) {
            $res['viewEntityFieldVOList'] = [];
            if (null !== $this->viewEntityFieldVOList && \is_array($this->viewEntityFieldVOList)) {
                $n = 0;
                foreach ($this->viewEntityFieldVOList as $item) {
                    $res['viewEntityFieldVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outerId'])) {
            $model->outerId = $map['outerId'];
        }
        if (isset($map['relationId'])) {
            $model->relationId = $map['relationId'];
        }
        if (isset($map['scopeCode'])) {
            $model->scopeCode = $map['scopeCode'];
        }
        if (isset($map['viewEntityCode'])) {
            $model->viewEntityCode = $map['viewEntityCode'];
        }
        if (isset($map['viewEntityFieldVOList'])) {
            if (!empty($map['viewEntityFieldVOList'])) {
                $model->viewEntityFieldVOList = [];
                $n = 0;
                foreach ($map['viewEntityFieldVOList'] as $item) {
                    $model->viewEntityFieldVOList[$n++] = null !== $item ? viewEntityFieldVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
