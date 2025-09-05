<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\LockDocByDelegatedPermissionRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dentryUuid
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @description This parameter is required.
     *
     * @example name
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'dentryUuid' => 'dentryUuid',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
