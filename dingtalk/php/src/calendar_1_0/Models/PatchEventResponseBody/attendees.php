<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\PatchEventResponseBody;

use AlibabaCloud\Tea\Model;

class attendees extends Model
{
    /**
     * @var string
     */
    public $displayName;

    /**
     * @var string
     */
    public $id;

    /**
     * @var bool
     */
    public $isOptional;

    /**
     * @var string
     */
    public $responseStatus;

    /**
     * @var bool
     */
    public $self;
    protected $_name = [
        'displayName'    => 'displayName',
        'id'             => 'id',
        'isOptional'     => 'isOptional',
        'responseStatus' => 'responseStatus',
        'self'           => 'self',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isOptional) {
            $res['isOptional'] = $this->isOptional;
        }
        if (null !== $this->responseStatus) {
            $res['responseStatus'] = $this->responseStatus;
        }
        if (null !== $this->self) {
            $res['self'] = $this->self;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attendees
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isOptional'])) {
            $model->isOptional = $map['isOptional'];
        }
        if (isset($map['responseStatus'])) {
            $model->responseStatus = $map['responseStatus'];
        }
        if (isset($map['self'])) {
            $model->self = $map['self'];
        }

        return $model;
    }
}
