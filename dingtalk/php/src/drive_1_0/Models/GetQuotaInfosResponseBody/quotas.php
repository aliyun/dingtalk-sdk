<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetQuotaInfosResponseBody;

use AlibabaCloud\Tea\Model;

class quotas extends Model
{
    /**
     * @var string
     */
    public $identifier;

    /**
     * @var int
     */
    public $quota;

    /**
     * @var string
     */
    public $type;

    /**
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'identifier' => 'identifier',
        'quota'      => 'quota',
        'type'       => 'type',
        'usedQuota'  => 'usedQuota',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->quota) {
            $res['quota'] = $this->quota;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return quotas
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['quota'])) {
            $model->quota = $map['quota'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
