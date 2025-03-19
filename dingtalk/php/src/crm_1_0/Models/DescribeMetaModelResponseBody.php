<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeMetaModelResponseBody\metaModelDTOList;
use AlibabaCloud\Tea\Model;

class DescribeMetaModelResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var metaModelDTOList[]
     */
    public $metaModelDTOList;
    protected $_name = [
        'metaModelDTOList' => 'metaModelDTOList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->metaModelDTOList) {
            $res['metaModelDTOList'] = [];
            if (null !== $this->metaModelDTOList && \is_array($this->metaModelDTOList)) {
                $n = 0;
                foreach ($this->metaModelDTOList as $item) {
                    $res['metaModelDTOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DescribeMetaModelResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['metaModelDTOList'])) {
            if (!empty($map['metaModelDTOList'])) {
                $model->metaModelDTOList = [];
                $n = 0;
                foreach ($map['metaModelDTOList'] as $item) {
                    $model->metaModelDTOList[$n++] = null !== $item ? metaModelDTOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
