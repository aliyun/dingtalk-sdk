<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGroupMemberByAppUidsRequest extends Model
{
    /**
     * @var int[]
     */
    public $appUids;
    protected $_name = [
        'appUids' => 'appUids',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUids) {
            $res['appUids'] = $this->appUids;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupMemberByAppUidsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUids'])) {
            if (!empty($map['appUids'])) {
                $model->appUids = $map['appUids'];
            }
        }

        return $model;
    }
}
