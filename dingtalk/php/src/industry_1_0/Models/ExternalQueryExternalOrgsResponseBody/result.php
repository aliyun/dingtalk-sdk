<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ExternalQueryExternalOrgsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 外部合作组织ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 外部合作组织名称
     *
     * @var string
     */
    public $corpName;
    protected $_name = [
        'corpId'   => 'corpId',
        'corpName' => 'corpName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }

        return $model;
    }
}
