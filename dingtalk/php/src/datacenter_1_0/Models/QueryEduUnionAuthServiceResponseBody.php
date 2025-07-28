<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryEduUnionAuthServiceResponseBody\authInfoModels;
use AlibabaCloud\Tea\Model;

class QueryEduUnionAuthServiceResponseBody extends Model
{
    /**
     * @var authInfoModels[]
     */
    public $authInfoModels;
    protected $_name = [
        'authInfoModels' => 'authInfoModels',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->authInfoModels) {
            $res['authInfoModels'] = [];
            if (null !== $this->authInfoModels && \is_array($this->authInfoModels)) {
                $n = 0;
                foreach ($this->authInfoModels as $item) {
                    $res['authInfoModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryEduUnionAuthServiceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authInfoModels'])) {
            if (!empty($map['authInfoModels'])) {
                $model->authInfoModels = [];
                $n = 0;
                foreach ($map['authInfoModels'] as $item) {
                    $model->authInfoModels[$n++] = null !== $item ? authInfoModels::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
