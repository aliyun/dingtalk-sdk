<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSignedDetailByPageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $signStatus;
    protected $_name = [
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'signStatus' => 'signStatus',
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
        if (null !== $this->signStatus) {
            $res['signStatus'] = $this->signStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSignedDetailByPageRequest
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
        if (isset($map['signStatus'])) {
            $model->signStatus = $map['signStatus'];
        }

        return $model;
    }
}
