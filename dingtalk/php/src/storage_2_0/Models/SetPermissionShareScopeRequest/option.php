<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SetPermissionShareScopeRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $canSearch;
    protected $_name = [
        'canSearch' => 'canSearch',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canSearch) {
            $res['canSearch'] = $this->canSearch;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canSearch'])) {
            $model->canSearch = $map['canSearch'];
        }

        return $model;
    }
}
