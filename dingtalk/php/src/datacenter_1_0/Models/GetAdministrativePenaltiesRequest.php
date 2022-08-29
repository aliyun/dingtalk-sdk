<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAdministrativePenaltiesRequest extends Model
{
    /**
     * @description 页数,第几页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页条数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 关键词
     *
     * @var string
     */
    public $searchKey;
    protected $_name = [
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'searchKey'  => 'searchKey',
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
        if (null !== $this->searchKey) {
            $res['searchKey'] = $this->searchKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAdministrativePenaltiesRequest
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
        if (isset($map['searchKey'])) {
            $model->searchKey = $map['searchKey'];
        }

        return $model;
    }
}
