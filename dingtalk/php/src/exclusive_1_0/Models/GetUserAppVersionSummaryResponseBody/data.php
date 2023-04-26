<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserAppVersionSummaryResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 6.0
     *
     * @var string
     */
    public $appVersion;

    /**
     * @example iOS
     *
     * @var string
     */
    public $client;

    /**
     * @example 组织1
     *
     * @var string
     */
    public $orgName;

    /**
     * @example 20210808
     *
     * @var string
     */
    public $statDate;

    /**
     * @example 10
     *
     * @var float
     */
    public $userCnt;
    protected $_name = [
        'appVersion' => 'appVersion',
        'client'     => 'client',
        'orgName'    => 'orgName',
        'statDate'   => 'statDate',
        'userCnt'    => 'userCnt',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appVersion) {
            $res['appVersion'] = $this->appVersion;
        }
        if (null !== $this->client) {
            $res['client'] = $this->client;
        }
        if (null !== $this->orgName) {
            $res['orgName'] = $this->orgName;
        }
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }
        if (null !== $this->userCnt) {
            $res['userCnt'] = $this->userCnt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appVersion'])) {
            $model->appVersion = $map['appVersion'];
        }
        if (isset($map['client'])) {
            $model->client = $map['client'];
        }
        if (isset($map['orgName'])) {
            $model->orgName = $map['orgName'];
        }
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }
        if (isset($map['userCnt'])) {
            $model->userCnt = $map['userCnt'];
        }

        return $model;
    }
}
