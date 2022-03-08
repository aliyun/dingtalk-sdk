<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectsResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 业务数据实例数组
     *
     * @var mixed[][]
     */
    public $bizObjects;

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
    protected $_name = [
        'bizObjects' => 'bizObjects',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'totalCount' => 'totalCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjects) {
            $res['bizObjects'] = $this->bizObjects;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
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
        if (isset($map['bizObjects'])) {
            if (!empty($map['bizObjects'])) {
                $model->bizObjects = $map['bizObjects'];
            }
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
