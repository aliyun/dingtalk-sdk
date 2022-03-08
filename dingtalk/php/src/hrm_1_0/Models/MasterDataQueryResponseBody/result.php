<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result\viewEntityFieldVOList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 唯一id
     *
     * @var string
     */
    public $outerId;

    /**
     * @description 关联id列表，一般为userId
     *
     * @var string
     */
    public $relationId;

    /**
     * @description 领域
     *
     * @var string
     */
    public $scopeCode;

    /**
     * @description 编码
     *
     * @var string
     */
    public $viewEntityCode;

    /**
     * @description 字段列表
     *
     * @var viewEntityFieldVOList[]
     */
    public $viewEntityFieldVOList;
    protected $_name = [
        'outerId'               => 'outerId',
        'relationId'            => 'relationId',
        'scopeCode'             => 'scopeCode',
        'viewEntityCode'        => 'viewEntityCode',
        'viewEntityFieldVOList' => 'viewEntityFieldVOList',
    ];

    public function validate()
    {
    }

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
                $n                            = 0;
                foreach ($map['viewEntityFieldVOList'] as $item) {
                    $model->viewEntityFieldVOList[$n++] = null !== $item ? viewEntityFieldVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
