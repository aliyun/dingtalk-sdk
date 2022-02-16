<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTodoWeekStatisticalDataResponseBody\metaList;
use AlibabaCloud\Tea\Model;

class QueryYydTodoWeekStatisticalDataResponseBody extends Model
{
    /**
     * @description 指标数据
     *
     * @var mixed[][]
     */
    public $dataList;

    /**
     * @description 指标元数据
     *
     * @var metaList[]
     */
    public $metaList;
    protected $_name = [
        'dataList' => 'dataList',
        'metaList' => 'metaList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataList) {
            $res['dataList'] = $this->dataList;
        }
        if (null !== $this->metaList) {
            $res['metaList'] = [];
            if (null !== $this->metaList && \is_array($this->metaList)) {
                $n = 0;
                foreach ($this->metaList as $item) {
                    $res['metaList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryYydTodoWeekStatisticalDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dataList'])) {
            if (!empty($map['dataList'])) {
                $model->dataList = $map['dataList'];
            }
        }
        if (isset($map['metaList'])) {
            if (!empty($map['metaList'])) {
                $model->metaList = [];
                $n               = 0;
                foreach ($map['metaList'] as $item) {
                    $model->metaList[$n++] = null !== $item ? metaList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
