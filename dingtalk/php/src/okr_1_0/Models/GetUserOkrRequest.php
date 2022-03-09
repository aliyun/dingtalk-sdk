<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class GetUserOkrRequest extends Model
{
    /**
     * @description 归属用户的ID
     *
     * @var Stream
     */
    public $ownerId;

    /**
     * @description 页码，默认 为 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页的个数，默认100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 周期 ID
     *
     * @var Stream
     */
    public $periodId;
    protected $_name = [
        'ownerId'    => 'ownerId',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'periodId'   => 'periodId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ownerId) {
            $res['ownerId'] = $this->ownerId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserOkrRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ownerId'])) {
            $model->ownerId = $map['ownerId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }

        return $model;
    }
}
