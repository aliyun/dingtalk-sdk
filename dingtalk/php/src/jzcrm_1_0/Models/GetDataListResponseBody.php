<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\GetDataListResponseBody\data;
use AlibabaCloud\Tea\Model;

class GetDataListResponseBody extends Model
{
    /**
     * @description 数据列表
     *
     * @var data[]
     */
    public $data;

    /**
     * @description 字段明细
     *
     * @var string[]
     */
    public $dataname;

    /**
     * @description 当前页码
     *
     * @var int
     */
    public $page;

    /**
     * @description 分页条数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 总条数
     *
     * @var int
     */
    public $totalCount;

    /**
     * @description 响应时间
     *
     * @var string
     */
    public $time;
    protected $_name = [
        'data'       => 'data',
        'dataname'   => 'dataname',
        'page'       => 'page',
        'pageSize'   => 'pageSize',
        'totalCount' => 'totalCount',
        'time'       => 'time',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = [];
            if (null !== $this->data && \is_array($this->data)) {
                $n = 0;
                foreach ($this->data as $item) {
                    $res['data'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dataname) {
            $res['dataname'] = $this->dataname;
        }
        if (null !== $this->page) {
            $res['page'] = $this->page;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDataListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            if (!empty($map['data'])) {
                $model->data = [];
                $n           = 0;
                foreach ($map['data'] as $item) {
                    $model->data[$n++] = null !== $item ? data::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dataname'])) {
            $model->dataname = $map['dataname'];
        }
        if (isset($map['page'])) {
            $model->page = $map['page'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }

        return $model;
    }
}
