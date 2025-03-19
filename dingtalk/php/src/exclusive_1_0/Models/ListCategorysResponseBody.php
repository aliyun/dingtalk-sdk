<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListCategorysResponseBody extends Model
{
    /**
     * @var string[][]
     */
    public $detailModelList;
    protected $_name = [
        'detailModelList' => 'detailModelList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->detailModelList) {
            $res['detailModelList'] = $this->detailModelList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListCategorysResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detailModelList'])) {
            if (!empty($map['detailModelList'])) {
                $model->detailModelList = $map['detailModelList'];
            }
        }

        return $model;
    }
}
