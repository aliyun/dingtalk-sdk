<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListMiniAppHistoryVersionRequest extends Model
{
    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 分页码
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 小程序id
     *
     * @var string
     */
    public $miniAppId;
    protected $_name = [
        'pageSize'   => 'pageSize',
        'pageNumber' => 'pageNumber',
        'miniAppId'  => 'miniAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListMiniAppHistoryVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }

        return $model;
    }
}
