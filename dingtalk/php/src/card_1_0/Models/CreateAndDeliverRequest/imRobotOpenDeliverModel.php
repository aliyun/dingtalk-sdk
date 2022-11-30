<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest;

use AlibabaCloud\Tea\Model;

class imRobotOpenDeliverModel extends Model
{
    /**
     * @var string
     */
    public $spaceType;
    protected $_name = [
        'spaceType' => 'spaceType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return imRobotOpenDeliverModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
        }

        return $model;
    }
}
