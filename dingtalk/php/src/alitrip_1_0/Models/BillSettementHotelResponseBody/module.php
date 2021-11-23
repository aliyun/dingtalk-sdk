<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementHotelResponseBody;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\BillSettementHotelResponseBody\module\dataList;
use AlibabaCloud\Tea\Model;

class module extends Model
{
    /**
     * @description 类目
     *
     * @var int
     */
    public $category;

    /**
     * @description 企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 数据集合
     *
     * @var dataList[]
     */
    public $dataList;

    /**
     * @description 记账更新结束日期
     *
     * @var string
     */
    public $periodEnd;

    /**
     * @description 记账更新开始日期
     *
     * @var string
     */
    public $periodStart;

    /**
     * @description 总数据量
     *
     * @var int
     */
    public $totalNum;
    protected $_name = [
        'category'    => 'category',
        'corpId'      => 'corpId',
        'dataList'    => 'dataList',
        'periodEnd'   => 'periodEnd',
        'periodStart' => 'periodStart',
        'totalNum'    => 'totalNum',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->dataList) {
            $res['dataList'] = [];
            if (null !== $this->dataList && \is_array($this->dataList)) {
                $n = 0;
                foreach ($this->dataList as $item) {
                    $res['dataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->periodEnd) {
            $res['periodEnd'] = $this->periodEnd;
        }
        if (null !== $this->periodStart) {
            $res['periodStart'] = $this->periodStart;
        }
        if (null !== $this->totalNum) {
            $res['totalNum'] = $this->totalNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return module
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['dataList'])) {
            if (!empty($map['dataList'])) {
                $model->dataList = [];
                $n               = 0;
                foreach ($map['dataList'] as $item) {
                    $model->dataList[$n++] = null !== $item ? dataList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['periodEnd'])) {
            $model->periodEnd = $map['periodEnd'];
        }
        if (isset($map['periodStart'])) {
            $model->periodStart = $map['periodStart'];
        }
        if (isset($map['totalNum'])) {
            $model->totalNum = $map['totalNum'];
        }

        return $model;
    }
}
