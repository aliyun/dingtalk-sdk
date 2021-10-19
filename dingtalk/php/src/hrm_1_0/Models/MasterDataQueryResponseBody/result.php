<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result\viewEntityFieldVOList;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryResponseBody\result\viewEntityMultiFieldVOList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $outerId;

    /**
     * @var string
     */
    public $scopeCode;

    /**
     * @var string
     */
    public $viewEntityCode;

    /**
     * @var viewEntityFieldVOList[]
     */
    public $viewEntityFieldVOList;

    /**
     * @var viewEntityMultiFieldVOList[]
     */
    public $viewEntityMultiFieldVOList;
    protected $_name = [
        'outerId'                    => 'outerId',
        'scopeCode'                  => 'scopeCode',
        'viewEntityCode'             => 'viewEntityCode',
        'viewEntityFieldVOList'      => 'viewEntityFieldVOList',
        'viewEntityMultiFieldVOList' => 'viewEntityMultiFieldVOList',
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
        if (null !== $this->viewEntityMultiFieldVOList) {
            $res['viewEntityMultiFieldVOList'] = [];
            if (null !== $this->viewEntityMultiFieldVOList && \is_array($this->viewEntityMultiFieldVOList)) {
                $n = 0;
                foreach ($this->viewEntityMultiFieldVOList as $item) {
                    $res['viewEntityMultiFieldVOList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['viewEntityMultiFieldVOList'])) {
            if (!empty($map['viewEntityMultiFieldVOList'])) {
                $model->viewEntityMultiFieldVOList = [];
                $n                                 = 0;
                foreach ($map['viewEntityMultiFieldVOList'] as $item) {
                    $model->viewEntityMultiFieldVOList[$n++] = null !== $item ? viewEntityMultiFieldVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
