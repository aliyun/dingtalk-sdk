<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSubCorpsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $isOnlyDirect;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @example county|community
     *
     * @var string
     */
    public $types;
    protected $_name = [
        'isOnlyDirect' => 'isOnlyDirect',
        'subCorpId'    => 'subCorpId',
        'types'        => 'types',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isOnlyDirect) {
            $res['isOnlyDirect'] = $this->isOnlyDirect;
        }
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->types) {
            $res['types'] = $this->types;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSubCorpsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isOnlyDirect'])) {
            $model->isOnlyDirect = $map['isOnlyDirect'];
        }
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['types'])) {
            $model->types = $map['types'];
        }

        return $model;
    }
}
