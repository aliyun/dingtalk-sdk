<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListCommodityRequest extends Model
{
    /**
     * @example accessKey
     *
     * @var string
     */
    public $accessKey;

    /**
     * @example callerUid
     *
     * @var string
     */
    public $callerUid;

    /**
     * @example currentPage
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example pageSize
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'accessKey'  => 'accessKey',
        'callerUid'  => 'callerUid',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
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
        if (null !== $this->callerUid) {
            $res['callerUid'] = $this->callerUid;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
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
        if (isset($map['callerUid'])) {
            $model->callerUid = $map['callerUid'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
