<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmcp_1_0\Models\GetSkillDetailResponseBody;

use AlibabaCloud\Tea\Model;

class dependencies extends Model
{
    /**
     * @var string
     */
    public $displayName;

    /**
     * @var string
     */
    public $refId;

    /**
     * @var bool
     */
    public $required;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'displayName' => 'displayName',
        'refId' => 'refId',
        'required' => 'required',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->refId) {
            $res['refId'] = $this->refId;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dependencies
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['refId'])) {
            $model->refId = $map['refId'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
