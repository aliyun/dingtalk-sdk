<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 页码
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 匹配条件的结果总数量
     *
     * @var int
     */
    public $totalCount;

    /**
     * @description 业务数据实例数组
     *
     * @var mixed[][]
     */
    public $bizObjects;
    protected $_name = [
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'totalCount' => 'totalCount',
        'bizObjects' => 'bizObjects',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }
        if (null !== $this->bizObjects) {
            $res['bizObjects'] = $this->bizObjects;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }
        if (isset($map['bizObjects'])) {
            if (!empty($map['bizObjects'])) {
                $model->bizObjects = $map['bizObjects'];
            }
        }

        return $model;
    }
}
