<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveResponseBody\failResult;
use AlibabaCloud\Tea\Model;

class MasterDataSaveResponseBody extends Model
{
    /**
     * @description 是否全部保存成功
     *
     * @var bool
     */
    public $allSuccess;

    /**
     * @description 保存失败的结果，全部保存成功时为空
     *
     * @var failResult[]
     */
    public $failResult;
    protected $_name = [
        'allSuccess' => 'allSuccess',
        'failResult' => 'failResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->allSuccess) {
            $res['allSuccess'] = $this->allSuccess;
        }
        if (null !== $this->failResult) {
            $res['failResult'] = [];
            if (null !== $this->failResult && \is_array($this->failResult)) {
                $n = 0;
                foreach ($this->failResult as $item) {
                    $res['failResult'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MasterDataSaveResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allSuccess'])) {
            $model->allSuccess = $map['allSuccess'];
        }
        if (isset($map['failResult'])) {
            if (!empty($map['failResult'])) {
                $model->failResult = [];
                $n                 = 0;
                foreach ($map['failResult'] as $item) {
                    $model->failResult[$n++] = null !== $item ? failResult::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
