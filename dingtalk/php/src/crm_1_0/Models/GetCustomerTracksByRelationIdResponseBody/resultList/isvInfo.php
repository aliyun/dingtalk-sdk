<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCustomerTracksByRelationIdResponseBody\resultList;

use AlibabaCloud\Tea\Model;

class isvInfo extends Model
{
    /**
     * @var string
     */
    public $appName;

    /**
     * @var string
     */
    public $orgName;
    protected $_name = [
        'appName' => 'appName',
        'orgName' => 'orgName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return isvInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }

        return $model;
    }
}
