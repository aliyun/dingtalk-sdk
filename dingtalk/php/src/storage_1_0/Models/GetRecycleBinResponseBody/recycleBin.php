<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetRecycleBinResponseBody;

use AlibabaCloud\Tea\Model;

class recycleBin extends Model
{
    /**
     * @example recyclebin_id
     *
     * @var string
     */
    public $id;

    /**
     * @example SPACE
     *
     * @var string
     */
    public $scope;

    /**
     * @example scope_id
     *
     * @var string
     */
    public $scopeId;
    protected $_name = [
        'id' => 'id',
        'scope' => 'scope',
        'scopeId' => 'scopeId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        if (null !== $this->scopeId) {
            $res['scopeId'] = $this->scopeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recycleBin
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }
        if (isset($map['scopeId'])) {
            $model->scopeId = $map['scopeId'];
        }

        return $model;
    }
}
