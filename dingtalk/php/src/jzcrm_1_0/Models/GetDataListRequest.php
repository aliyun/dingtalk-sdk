<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDataListRequest extends Model
{
    /**
     * @description 数据类型，参考数据类型ID对照表
     *
     * @var string
     */
    public $datatype;

    /**
     * @description 页码
     *
     * @var int
     */
    public $page;

    /**
     * @description 分页条数
     *
     * @var int
     */
    public $pagesize;
    protected $_name = [
        'datatype' => 'datatype',
        'page'     => 'page',
        'pagesize' => 'pagesize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->datatype) {
            $res['datatype'] = $this->datatype;
        }
        if (null !== $this->page) {
            $res['page'] = $this->page;
        }
        if (null !== $this->pagesize) {
            $res['pagesize'] = $this->pagesize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDataListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['datatype'])) {
            $model->datatype = $map['datatype'];
        }
        if (isset($map['page'])) {
            $model->page = $map['page'];
        }
        if (isset($map['pagesize'])) {
            $model->pagesize = $map['pagesize'];
        }

        return $model;
    }
}
