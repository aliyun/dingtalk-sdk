<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\FileStorageGetQuotaDataResponseBody\quotaModelList;
use AlibabaCloud\Tea\Model;

class FileStorageGetQuotaDataResponseBody extends Model
{
    /**
     * @description 文件存储使用容量列表
     *
     * @var quotaModelList[]
     */
    public $quotaModelList;
    protected $_name = [
        'quotaModelList' => 'quotaModelList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->quotaModelList) {
            $res['quotaModelList'] = [];
            if (null !== $this->quotaModelList && \is_array($this->quotaModelList)) {
                $n = 0;
                foreach ($this->quotaModelList as $item) {
                    $res['quotaModelList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FileStorageGetQuotaDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['quotaModelList'])) {
            if (!empty($map['quotaModelList'])) {
                $model->quotaModelList = [];
                $n                     = 0;
                foreach ($map['quotaModelList'] as $item) {
                    $model->quotaModelList[$n++] = null !== $item ? quotaModelList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
