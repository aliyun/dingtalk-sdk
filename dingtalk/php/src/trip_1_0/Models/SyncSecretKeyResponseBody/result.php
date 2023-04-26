<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncSecretKeyResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example dsiuuuuiasudnuai
     *
     * @var string
     */
    public $secretString;

    /**
     * @example ding001
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @example dingwieudsiu
     *
     * @var string
     */
    public $tripAppKey;

    /**
     * @example dusuduiidvs
     *
     * @var string
     */
    public $tripAppSecurity;

    /**
     * @example isv001
     *
     * @var string
     */
    public $tripCorpId;
    protected $_name = [
        'secretString'    => 'secretString',
        'targetCorpId'    => 'targetCorpId',
        'tripAppKey'      => 'tripAppKey',
        'tripAppSecurity' => 'tripAppSecurity',
        'tripCorpId'      => 'tripCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->secretString) {
            $res['secretString'] = $this->secretString;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->tripAppKey) {
            $res['tripAppKey'] = $this->tripAppKey;
        }
        if (null !== $this->tripAppSecurity) {
            $res['tripAppSecurity'] = $this->tripAppSecurity;
        }
        if (null !== $this->tripCorpId) {
            $res['tripCorpId'] = $this->tripCorpId;
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
        if (isset($map['secretString'])) {
            $model->secretString = $map['secretString'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['tripAppKey'])) {
            $model->tripAppKey = $map['tripAppKey'];
        }
        if (isset($map['tripAppSecurity'])) {
            $model->tripAppSecurity = $map['tripAppSecurity'];
        }
        if (isset($map['tripCorpId'])) {
            $model->tripCorpId = $map['tripCorpId'];
        }

        return $model;
    }
}
