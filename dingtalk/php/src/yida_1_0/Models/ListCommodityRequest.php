<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListCommodityRequest extends Model
{
    /**
     * @description accessKey
     *
     * @var string
     */
    public $accessKey;

    /**
     * @description pageSize
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description callerUid
     *
     * @var string
     */
    public $callerUid;

    /**
     * @description currentPage
     *
     * @var int
     */
    public $pageNumber;
    protected $_name = [
        'accessKey'  => 'accessKey',
        'pageSize'   => 'pageSize',
        'callerUid'  => 'callerUid',
        'pageNumber' => 'pageNumber',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKey) {
            $res['accessKey'] = $this->accessKey;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->callerUid) {
            $res['callerUid'] = $this->callerUid;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListCommodityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKey'])) {
            $model->accessKey = $map['accessKey'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['callerUid'])) {
            $model->callerUid = $map['callerUid'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }

        return $model;
    }
}
