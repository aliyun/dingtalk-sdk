<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsResponseBody\result;

use AlibabaCloud\Tea\Model;

class openHonors extends Model
{
    /**
     * @var string
     */
    public $honorDesc;

    /**
     * @var int
     */
    public $honorId;

    /**
     * @var string
     */
    public $honorImgUrl;

    /**
     * @var string
     */
    public $honorName;

    /**
     * @var string
     */
    public $honorPendantImgUrl;
    protected $_name = [
        'honorDesc'          => 'honorDesc',
        'honorId'            => 'honorId',
        'honorImgUrl'        => 'honorImgUrl',
        'honorName'          => 'honorName',
        'honorPendantImgUrl' => 'honorPendantImgUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->honorDesc) {
            $res['honorDesc'] = $this->honorDesc;
        }
        if (null !== $this->honorId) {
            $res['honorId'] = $this->honorId;
        }
        if (null !== $this->honorImgUrl) {
            $res['honorImgUrl'] = $this->honorImgUrl;
        }
        if (null !== $this->honorName) {
            $res['honorName'] = $this->honorName;
        }
        if (null !== $this->honorPendantImgUrl) {
            $res['honorPendantImgUrl'] = $this->honorPendantImgUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openHonors
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['honorDesc'])) {
            $model->honorDesc = $map['honorDesc'];
        }
        if (isset($map['honorId'])) {
            $model->honorId = $map['honorId'];
        }
        if (isset($map['honorImgUrl'])) {
            $model->honorImgUrl = $map['honorImgUrl'];
        }
        if (isset($map['honorName'])) {
            $model->honorName = $map['honorName'];
        }
        if (isset($map['honorPendantImgUrl'])) {
            $model->honorPendantImgUrl = $map['honorPendantImgUrl'];
        }

        return $model;
    }
}
