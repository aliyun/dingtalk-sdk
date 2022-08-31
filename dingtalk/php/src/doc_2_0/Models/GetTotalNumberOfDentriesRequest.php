<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetTotalNumberOfDentriesRequest extends Model
{
    /**
     * @description 是否包含文件夹。默认包含。
     *
     * @var bool
     */
    public $includeFolder;

    /**
     * @description 操作用户unionId。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 统计指定的知识库类型。0-我的文档；1-知识库。如果不传，则会统计全部数据。
     *
     * @var string
     */
    public $spaceTypes;
    protected $_name = [
        'includeFolder' => 'includeFolder',
        'operatorId'    => 'operatorId',
        'spaceTypes'    => 'spaceTypes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->includeFolder) {
            $res['includeFolder'] = $this->includeFolder;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->spaceTypes) {
            $res['spaceTypes'] = $this->spaceTypes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTotalNumberOfDentriesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['includeFolder'])) {
            $model->includeFolder = $map['includeFolder'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['spaceTypes'])) {
            $model->spaceTypes = $map['spaceTypes'];
        }

        return $model;
    }
}
