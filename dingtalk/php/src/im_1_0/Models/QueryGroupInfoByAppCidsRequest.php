<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGroupInfoByAppCidsRequest extends Model
{
    /**
     * @var string[]
     */
    public $appCids;
    protected $_name = [
        'appCids' => 'appCids',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appCids) {
            $res['appCids'] = $this->appCids;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupInfoByAppCidsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appCids'])) {
            if (!empty($map['appCids'])) {
                $model->appCids = $map['appCids'];
            }
        }

        return $model;
    }
}
