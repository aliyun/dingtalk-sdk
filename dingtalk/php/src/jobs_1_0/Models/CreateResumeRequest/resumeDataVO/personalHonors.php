<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest\resumeDataVO;

use AlibabaCloud\Tea\Model;

class personalHonors extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $grantTime;
    protected $_name = [
        'description' => 'description',
        'grantTime'   => 'grantTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->grantTime) {
            $res['grantTime'] = $this->grantTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return personalHonors
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['grantTime'])) {
            $model->grantTime = $map['grantTime'];
        }

        return $model;
    }
}
