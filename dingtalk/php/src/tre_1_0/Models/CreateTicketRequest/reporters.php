<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtre_1_0\Models\CreateTicketRequest;

use AlibabaCloud\Tea\Model;

class reporters extends Model
{
    /**
     * @var string
     */
    public $carrier;

    /**
     * @var string
     */
    public $phone;

    /**
     * @var string
     */
    public $region;

    /**
     * @var string
     */
    public $role;

    /**
     * @var string[]
     */
    public $screenshots;

    /**
     * @var int
     */
    public $timestamp;

    /**
     * @var string
     */
    public $uid;

    /**
     * @var string
     */
    public $version;
    protected $_name = [
        'carrier' => 'carrier',
        'phone' => 'phone',
        'region' => 'region',
        'role' => 'role',
        'screenshots' => 'screenshots',
        'timestamp' => 'timestamp',
        'uid' => 'uid',
        'version' => 'version',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->carrier) {
            $res['carrier'] = $this->carrier;
        }
        if (null !== $this->phone) {
            $res['phone'] = $this->phone;
        }
        if (null !== $this->region) {
            $res['region'] = $this->region;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->screenshots) {
            $res['screenshots'] = $this->screenshots;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->uid) {
            $res['uid'] = $this->uid;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reporters
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['carrier'])) {
            $model->carrier = $map['carrier'];
        }
        if (isset($map['phone'])) {
            $model->phone = $map['phone'];
        }
        if (isset($map['region'])) {
            $model->region = $map['region'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['screenshots'])) {
            if (!empty($map['screenshots'])) {
                $model->screenshots = $map['screenshots'];
            }
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['uid'])) {
            $model->uid = $map['uid'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
