<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetSaleUserInfoByUserIdResponseBody;

use AlibabaCloud\Tea\Model;

class corpList extends Model
{
    /**
     * @description namespace
     *
     * @var string
     */
    public $namespace;

    /**
     * @description corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description corpName
     *
     * @var string
     */
    public $corpName;
    protected $_name = [
        'namespace' => 'namespace',
        'corpId'    => 'corpId',
        'corpName'  => 'corpName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->namespace) {
            $res['namespace'] = $this->namespace;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return corpList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['namespace'])) {
            $model->namespace = $map['namespace'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }

        return $model;
    }
}
