<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetOrgResponseBody\org;
use AlibabaCloud\Tea\Model;

class GetOrgResponseBody extends Model
{
    /**
     * @description 企业信息
     *
     * @var org
     */
    public $org;
    protected $_name = [
        'org' => 'org',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->org) {
            $res['org'] = null !== $this->org ? $this->org->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOrgResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['org'])) {
            $model->org = org::fromMap($map['org']);
        }

        return $model;
    }
}
